-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, owner, ratio) VALUES ('stable', 'latest', 77.04);
INSERT INTO layout_items (state, owner, ratio) VALUES ('fallback', 'edge', 7.07);
INSERT INTO layout_items (state, owner, ratio) VALUES ('green', 'local', 47.02);
