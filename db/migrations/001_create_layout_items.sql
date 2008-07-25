-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, level, owner) VALUES ('primary', 80, 'standard');
INSERT INTO layout_items (state, level, owner) VALUES ('green', 35, 'staging');
INSERT INTO layout_items (state, level, owner) VALUES ('staging', 37, 'strict');
