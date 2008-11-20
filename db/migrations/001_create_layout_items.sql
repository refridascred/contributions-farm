-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, region, rank, owner) VALUES ('fallback', 'strict', 93, 'blue');
INSERT INTO layout_items (state, region, rank, owner) VALUES ('fallback', 'legacy', 28, 'green');
INSERT INTO layout_items (state, region, rank, owner) VALUES ('staging', 'open', 50, 'standard');
