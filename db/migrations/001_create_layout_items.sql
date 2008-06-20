-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, ratio, count, rank) VALUES (12, 23.19, 78, 99);
INSERT INTO layout_items (active, ratio, count, rank) VALUES (99, 55.85, 10, 65);
INSERT INTO layout_items (active, ratio, count, rank) VALUES (36, 61.24, 65, 60);
