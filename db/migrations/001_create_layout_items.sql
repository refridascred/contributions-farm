-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, weight, region) VALUES (41, 20.47, 'open');
INSERT INTO layout_items (level, weight, region) VALUES (48, 57.37, 'edge');
INSERT INTO layout_items (level, weight, region) VALUES (99, 89.31, 'cached');
