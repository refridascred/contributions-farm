-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, ratio, owner, level, region) VALUES ('legacy', 19.51, 'green', 64, 'open');
INSERT INTO layout_items (label, ratio, owner, level, region) VALUES ('stable', 97.48, 'cached', 19, 'fallback');
