-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, label, state, ratio) VALUES (22, 'primary', 'legacy', 29.8);
INSERT INTO layout_items (active, label, state, ratio) VALUES (83, 'edge', 'eu-west', 53.91);
INSERT INTO layout_items (active, label, state, ratio) VALUES (60, 'latest', 'standard', 71.37);
