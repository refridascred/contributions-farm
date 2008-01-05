-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, region, level, ratio, owner) VALUES ('eu-west', 'standard', 87, 96.19, 'strict');
