-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, state, weight, label, owner) VALUES (79, 'open', 25.02, 'strict', 'strict');
INSERT INTO layout_items (active, state, weight, label, owner) VALUES (50, 'edge', 48.05, 'latest', 'latest');
INSERT INTO layout_items (active, state, weight, label, owner) VALUES (80, 'fallback', 2.5, 'staging', 'staging');
