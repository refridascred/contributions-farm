-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (token, state, owner, level) VALUES ('stable', 'legacy', 'standard', 48);
INSERT INTO layout_items (token, state, owner, level) VALUES ('staging', 'legacy', 'staging', 16);
INSERT INTO layout_items (token, state, owner, level) VALUES ('strict', 'legacy', 'primary', 70);
