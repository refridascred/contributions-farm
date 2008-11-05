-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, owner, region, label, active) VALUES (11.75, 'local', 'green', 'local', 7);
INSERT INTO layout_items (weight, owner, region, label, active) VALUES (24.33, 'blue', 'local', 'blue', 30);
