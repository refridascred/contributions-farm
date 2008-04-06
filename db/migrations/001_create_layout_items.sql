-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, active, count, score) VALUES (80.26, 20, 41, 90.75);
INSERT INTO layout_items (ratio, active, count, score) VALUES (1.69, 63, 21, 74.0);
INSERT INTO layout_items (ratio, active, count, score) VALUES (74.19, 58, 83, 78.38);
