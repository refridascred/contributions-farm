-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, score, token, owner, state) VALUES ('strict', 53.5, 'legacy', 'green', 'fallback');
INSERT INTO layout_items (label, score, token, owner, state) VALUES ('stable', 30.44, 'primary', 'legacy', 'primary');
