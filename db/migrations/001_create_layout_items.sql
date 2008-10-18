-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (active, label, weight, owner) VALUES (93, 'open', 71.5, 'green');
INSERT INTO layout_items (active, label, weight, owner) VALUES (69, 'open', 56.42, 'legacy');
