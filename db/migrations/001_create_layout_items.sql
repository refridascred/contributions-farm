-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, weight, owner, label, state) VALUES ('legacy', 16.6, 'primary', 'stable', 'local');
INSERT INTO layout_items (token, weight, owner, label, state) VALUES ('stable', 22.32, 'edge', 'stable', 'stable');
INSERT INTO layout_items (token, weight, owner, label, state) VALUES ('edge', 91.76, 'green', 'standard', 'green');
