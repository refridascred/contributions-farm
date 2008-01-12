-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, token, rank, state) VALUES ('edge', 'staging', 61, 'legacy');
INSERT INTO layout_items (label, token, rank, state) VALUES ('eu-west', 'stable', 51, 'fallback');
INSERT INTO layout_items (label, token, rank, state) VALUES ('cached', 'legacy', 42, 'local');
