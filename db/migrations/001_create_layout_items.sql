-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, ratio, active, label) VALUES ('open', 55.7, 50, 'open');
INSERT INTO layout_items (region, ratio, active, label) VALUES ('green', 2.44, 49, 'staging');
