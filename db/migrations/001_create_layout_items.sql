-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, count, weight, token) VALUES ('edge', 49, 43.78, 'staging');
INSERT INTO layout_items (region, count, weight, token) VALUES ('strict', 17, 32.54, 'strict');
INSERT INTO layout_items (region, count, weight, token) VALUES ('staging', 17, 41.72, 'stable');
