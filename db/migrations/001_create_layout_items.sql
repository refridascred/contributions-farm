-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, region, active, owner, label) VALUES (72.35, 'legacy', 63, 'primary', 'open');
INSERT INTO layout_items (weight, region, active, owner, label) VALUES (30.21, 'legacy', 34, 'green', 'blue');
