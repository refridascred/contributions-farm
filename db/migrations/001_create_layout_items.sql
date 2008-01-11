-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, owner, state, rank) VALUES ('strict', 'staging', 'cached', 99);
INSERT INTO layout_items (region, owner, state, rank) VALUES ('fallback', 'local', 'stable', 54);
