-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, count, score) VALUES (41.61, 43, 85.82);
INSERT INTO layout_items (ratio, count, score) VALUES (26.63, 36, 73.19);
INSERT INTO layout_items (ratio, count, score) VALUES (59.72, 2, 61.35);
