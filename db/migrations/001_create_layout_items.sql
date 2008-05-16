-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, ratio, weight, active, region) VALUES ('primary', 17.89, 3.69, 34, 'edge');
INSERT INTO layout_items (owner, ratio, weight, active, region) VALUES ('fallback', 70.97, 32.65, 46, 'local');
INSERT INTO layout_items (owner, ratio, weight, active, region) VALUES ('eu-west', 46.72, 90.4, 78, 'legacy');
