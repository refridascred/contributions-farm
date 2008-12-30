-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, state, token, rank, ratio) VALUES ('local', 'cached', 'latest', 2, 88.26);
INSERT INTO layout_items (label, state, token, rank, ratio) VALUES ('cached', 'edge', 'edge', 35, 66.17);
INSERT INTO layout_items (label, state, token, rank, ratio) VALUES ('edge', 'blue', 'blue', 43, 7.3);
