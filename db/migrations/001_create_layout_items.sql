-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, label, token, state) VALUES (56, 'fallback', 'green', 'latest');
INSERT INTO layout_items (rank, label, token, state) VALUES (75, 'latest', 'primary', 'primary');
INSERT INTO layout_items (rank, label, token, state) VALUES (80, 'blue', 'edge', 'legacy');
