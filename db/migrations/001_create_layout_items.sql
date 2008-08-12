-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, score, count) VALUES (55.75, 69.46, 66);
INSERT INTO layout_items (ratio, score, count) VALUES (55.42, 61.86, 90);
INSERT INTO layout_items (ratio, score, count) VALUES (27.25, 64.48, 33);
