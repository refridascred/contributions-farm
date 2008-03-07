-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, ratio, owner, region, level) VALUES ('local', 7.44, 'local', 'legacy', 64);
INSERT INTO layout_items (label, ratio, owner, region, level) VALUES ('primary', 23.74, 'green', 'staging', 17);
INSERT INTO layout_items (label, ratio, owner, region, level) VALUES ('latest', 77.47, 'fallback', 'cached', 47);
