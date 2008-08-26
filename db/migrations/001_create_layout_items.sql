-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, active, region, owner, score) VALUES ('cached', 65, 'legacy', 'green', 68.82);
INSERT INTO layout_items (state, active, region, owner, score) VALUES ('standard', 69, 'standard', 'local', 91.79);
