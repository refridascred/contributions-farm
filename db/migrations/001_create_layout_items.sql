-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (ratio, active, level, region) VALUES (64.37, 5, 40, 'eu-west');
INSERT INTO layout_items (ratio, active, level, region) VALUES (42.84, 14, 66, 'open');
INSERT INTO layout_items (ratio, active, level, region) VALUES (55.56, 5, 84, 'staging');
