-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (level, token, ratio, owner, state) VALUES (60, 'legacy', 93.59, 'legacy', 'strict');
INSERT INTO layout_items (level, token, ratio, owner, state) VALUES (37, 'strict', 55.42, 'cached', 'staging');
