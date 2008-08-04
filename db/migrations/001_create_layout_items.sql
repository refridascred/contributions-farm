-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, active, region, state) VALUES (13.99, 48, 'stable', 'local');
INSERT INTO layout_items (score, active, region, state) VALUES (60.14, 65, 'local', 'primary');
INSERT INTO layout_items (score, active, region, state) VALUES (39.25, 41, 'fallback', 'legacy');
