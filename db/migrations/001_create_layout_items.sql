-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, level, region) VALUES (93.57, 22, 'staging');
INSERT INTO layout_items (ratio, level, region) VALUES (32.01, 55, 'stable');
INSERT INTO layout_items (ratio, level, region) VALUES (36.68, 40, 'open');
