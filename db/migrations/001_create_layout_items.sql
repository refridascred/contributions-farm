-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, owner, state, token, weight) VALUES (67, 'fallback', 'fallback', 'blue', 37.14);
INSERT INTO layout_items (level, owner, state, token, weight) VALUES (46, 'stable', 'staging', 'latest', 59.35);
INSERT INTO layout_items (level, owner, state, token, weight) VALUES (55, 'latest', 'stable', 'stable', 17.37);
