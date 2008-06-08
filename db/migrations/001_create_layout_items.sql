-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, rank, token, state) VALUES (66, 49, 'blue', 'eu-west');
INSERT INTO layout_items (active, rank, token, state) VALUES (57, 4, 'legacy', 'stable');
INSERT INTO layout_items (active, rank, token, state) VALUES (93, 17, 'primary', 'latest');
