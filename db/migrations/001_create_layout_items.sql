-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (level, owner, ratio, region) VALUES (47, 'eu-west', 40.52, 'strict');
INSERT INTO layout_items (level, owner, ratio, region) VALUES (37, 'standard', 72.61, 'primary');
INSERT INTO layout_items (level, owner, ratio, region) VALUES (56, 'primary', 31.61, 'local');
