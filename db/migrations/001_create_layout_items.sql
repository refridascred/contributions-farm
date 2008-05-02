-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, label, active, owner) VALUES (64.41, 'strict', 30, 'green');
INSERT INTO layout_items (ratio, label, active, owner) VALUES (16.24, 'local', 32, 'eu-west');
INSERT INTO layout_items (ratio, label, active, owner) VALUES (18.75, 'legacy', 43, 'cached');
