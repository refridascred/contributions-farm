-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, rank, state) VALUES ('latest', 76, 'strict');
INSERT INTO layout_items (owner, rank, state) VALUES ('open', 54, 'green');
INSERT INTO layout_items (owner, rank, state) VALUES ('fallback', 17, 'legacy');
