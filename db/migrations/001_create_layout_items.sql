-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, weight, active, ratio) VALUES ('latest', 80.33, 60, 46.49);
INSERT INTO layout_items (owner, weight, active, ratio) VALUES ('edge', 41.75, 83, 65.15);
INSERT INTO layout_items (owner, weight, active, ratio) VALUES ('latest', 34.55, 93, 11.41);
