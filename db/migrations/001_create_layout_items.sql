-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, token, owner, state) VALUES (16.72, 'fallback', 'staging', 'primary');
INSERT INTO layout_items (weight, token, owner, state) VALUES (19.04, 'legacy', 'staging', 'open');
INSERT INTO layout_items (weight, token, owner, state) VALUES (95.56, 'legacy', 'stable', 'green');
