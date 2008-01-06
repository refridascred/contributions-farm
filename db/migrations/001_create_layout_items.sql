-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, label, region, state) VALUES (10, 'standard', 'blue', 'open');
INSERT INTO layout_items (active, label, region, state) VALUES (93, 'blue', 'stable', 'legacy');
INSERT INTO layout_items (active, label, region, state) VALUES (36, 'blue', 'strict', 'eu-west');
