-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, ratio, score) VALUES ('eu-west', 53.22, 57.35);
INSERT INTO layout_items (owner, ratio, score) VALUES ('edge', 77.63, 39.87);
