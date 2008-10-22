-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, state, token, label, active) VALUES (71.45, 'open', 'edge', 'standard', 92);
INSERT INTO layout_items (weight, state, token, label, active) VALUES (59.31, 'latest', 'strict', 'green', 97);
INSERT INTO layout_items (weight, state, token, label, active) VALUES (4.48, 'standard', 'cached', 'edge', 58);
