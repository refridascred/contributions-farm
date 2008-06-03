-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (region, score, weight, ratio) VALUES ('standard', 49.44, 0.93, 8.24);
INSERT INTO layout_items (region, score, weight, ratio) VALUES ('eu-west', 78.97, 14.1, 20.65);
