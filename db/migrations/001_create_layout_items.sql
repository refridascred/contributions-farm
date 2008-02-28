-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (label, token, active, state) VALUES ('local', 'blue', 38, 'strict');
INSERT INTO layout_items (label, token, active, state) VALUES ('edge', 'open', 87, 'open');
INSERT INTO layout_items (label, token, active, state) VALUES ('latest', 'strict', 89, 'primary');
