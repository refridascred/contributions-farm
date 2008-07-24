-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, weight, state, owner) VALUES (89, 5.5, 'legacy', 'fallback');
INSERT INTO layout_items (level, weight, state, owner) VALUES (79, 71.83, 'open', 'primary');
