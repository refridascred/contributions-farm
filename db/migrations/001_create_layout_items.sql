-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, rank, level, state) VALUES ('staging', 43, 97, 'open');
INSERT INTO layout_items (owner, rank, level, state) VALUES ('fallback', 9, 26, 'stable');
INSERT INTO layout_items (owner, rank, level, state) VALUES ('fallback', 94, 93, 'blue');
