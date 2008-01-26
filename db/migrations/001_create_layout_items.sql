-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (region, owner, state) VALUES ('stable', 'green', 'cached');
INSERT INTO layout_items (region, owner, state) VALUES ('open', 'eu-west', 'fallback');
