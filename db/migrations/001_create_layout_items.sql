-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, token, active, label) VALUES ('latest', 'cached', 65, 'blue');
INSERT INTO layout_items (state, token, active, label) VALUES ('open', 'latest', 76, 'edge');
INSERT INTO layout_items (state, token, active, label) VALUES ('green', 'standard', 71, 'strict');
