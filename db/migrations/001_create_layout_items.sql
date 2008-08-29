-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, state, rank, level) VALUES ('green', 'strict', 66, 22);
INSERT INTO layout_items (owner, state, rank, level) VALUES ('fallback', 'standard', 98, 42);
