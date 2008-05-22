-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, owner, token, level, state) VALUES ('eu-west', 'blue', 'primary', 57, 'open');
INSERT INTO layout_items (region, owner, token, level, state) VALUES ('open', 'green', 'green', 14, 'legacy');
INSERT INTO layout_items (region, owner, token, level, state) VALUES ('eu-west', 'stable', 'standard', 18, 'staging');
