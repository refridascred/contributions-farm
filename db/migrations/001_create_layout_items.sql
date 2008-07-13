-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, state, owner, level) VALUES ('green', 'strict', 'strict', 97);
INSERT INTO layout_items (region, state, owner, level) VALUES ('eu-west', 'green', 'fallback', 7);
