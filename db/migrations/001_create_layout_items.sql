-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, state, region, rank) VALUES ('stable', 'fallback', 'strict', 94);
INSERT INTO layout_items (owner, state, region, rank) VALUES ('staging', 'eu-west', 'standard', 25);
