-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (state, weight, region, ratio, count) VALUES ('stable', 71.15, 'strict', 54.66, 0);
INSERT INTO layout_items (state, weight, region, ratio, count) VALUES ('blue', 91.53, 'stable', 92.37, 91);
INSERT INTO layout_items (state, weight, region, ratio, count) VALUES ('strict', 53.32, 'legacy', 65.31, 31);
