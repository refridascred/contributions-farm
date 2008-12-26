-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, rank, label) VALUES ('edge', 9, 'blue');
INSERT INTO layout_items (state, rank, label) VALUES ('edge', 21, 'cached');
INSERT INTO layout_items (state, rank, label) VALUES ('strict', 89, 'blue');
