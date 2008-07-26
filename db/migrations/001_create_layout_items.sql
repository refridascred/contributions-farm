-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, level, token, label, state) VALUES (70.13, 61, 'staging', 'cached', 'fallback');
INSERT INTO layout_items (ratio, level, token, label, state) VALUES (77.48, 92, 'strict', 'eu-west', 'local');
