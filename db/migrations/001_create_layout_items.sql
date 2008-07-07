-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (label, state, token, level) VALUES ('primary', 'blue', 'fallback', 79);
INSERT INTO layout_items (label, state, token, level) VALUES ('eu-west', 'legacy', 'edge', 9);
INSERT INTO layout_items (label, state, token, level) VALUES ('staging', 'primary', 'blue', 95);
