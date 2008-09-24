-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, rank, label, owner, state) VALUES ('edge', 69, 'blue', 'edge', 'cached');
INSERT INTO layout_items (token, rank, label, owner, state) VALUES ('primary', 75, 'stable', 'blue', 'blue');
INSERT INTO layout_items (token, rank, label, owner, state) VALUES ('legacy', 17, 'legacy', 'latest', 'edge');
