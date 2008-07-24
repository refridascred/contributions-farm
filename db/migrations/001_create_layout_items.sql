-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, rank, active, state) VALUES ('eu-west', 64, 76, 'standard');
INSERT INTO layout_items (token, rank, active, state) VALUES ('legacy', 81, 10, 'local');
INSERT INTO layout_items (token, rank, active, state) VALUES ('cached', 36, 7, 'strict');
