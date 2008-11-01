-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (label, token, rank, state) VALUES ('local', 'standard', 57, 'primary');
INSERT INTO layout_items (label, token, rank, state) VALUES ('green', 'local', 47, 'legacy');
