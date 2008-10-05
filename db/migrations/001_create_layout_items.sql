-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, level, ratio, owner, label) VALUES ('edge', 64, 47.93, 'fallback', 'standard');
INSERT INTO layout_items (region, level, ratio, owner, label) VALUES ('eu-west', 10, 26.23, 'fallback', 'local');
