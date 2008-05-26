-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, count, label, region) VALUES ('stable', 91, 'primary', 'blue');
INSERT INTO layout_items (owner, count, label, region) VALUES ('primary', 14, 'strict', 'eu-west');
