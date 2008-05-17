-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, state, label, token) VALUES (74, 'green', 'stable', 'edge');
INSERT INTO layout_items (rank, state, label, token) VALUES (45, 'edge', 'open', 'stable');
INSERT INTO layout_items (rank, state, label, token) VALUES (76, 'blue', 'eu-west', 'staging');
