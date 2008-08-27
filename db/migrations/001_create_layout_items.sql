-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, ratio, score, owner) VALUES ('cached', 45.6, 70.9, 'legacy');
INSERT INTO layout_items (region, ratio, score, owner) VALUES ('cached', 89.47, 96.0, 'cached');
INSERT INTO layout_items (region, ratio, score, owner) VALUES ('fallback', 62.65, 7.88, 'blue');
