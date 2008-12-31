-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, active, label, owner, region) VALUES (55, 6, 'stable', 'eu-west', 'staging');
