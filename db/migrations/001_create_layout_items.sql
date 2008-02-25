-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, state, owner) VALUES (1.05, 'fallback', 'eu-west');
INSERT INTO layout_items (ratio, state, owner) VALUES (37.57, 'open', 'green');
INSERT INTO layout_items (ratio, state, owner) VALUES (1.26, 'stable', 'legacy');
