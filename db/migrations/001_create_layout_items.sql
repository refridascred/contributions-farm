-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (weight, label, owner, count, state) VALUES (83.96, 'cached', 'primary', 13, 'local');
INSERT INTO layout_items (weight, label, owner, count, state) VALUES (50.25, 'edge', 'staging', 55, 'legacy');
